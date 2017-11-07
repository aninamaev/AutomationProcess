using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QQInfoAppDoi.View
{
    public class SchedulerPage : ContentPage
    {
        public SchedulerPage(User user)
        {
            //Title = $"{user.Name}'s scheduler for {DateTime.Now.ToString("M")}";
            Title = $"Tasks for {user.Name} on {DateTime.Now.ToString("M")}";

            var assignmentList = FakeInfo.ReturnUsersAssignmentsList();

            #region columns definition
            var columnSize = (int)(10 / assignmentList.Count);
            var taskLabels = new Label[assignmentList.Count];

            var grid = new Grid() { BackgroundColor = QqinfoAppSettings.GrayColor, RowSpacing = 2, ColumnSpacing = 2 };
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 40 });
            for (var i = 0; i < assignmentList.Count; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(columnSize, GridUnitType.Star) });

                taskLabels[i] = new Label()
                {
                    Text = assignmentList[i].Name,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = QqinfoAppSettings.SchedulerTextFontSize,
                    BackgroundColor = QqinfoAppSettings.WhiteColor,
                    TextColor = QqinfoAppSettings.BlueColor
                };
                grid.Children.Add(new StackLayout() { BackgroundColor = QqinfoAppSettings.WhiteColor, Children = { taskLabels[i] } }, i + 1, 0);
            }
            #endregion

            #region define rows
            for (var i = 0; i < 10; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            }
            #endregion

            #region hours label
            for (var i = 0; i < 9; i++)
            {
                var thisHour = 8 + i;
                var hourLabel = new Label()
                {
                    Text = $"{thisHour}:00",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 14,
                    BackgroundColor = QqinfoAppSettings.WhiteColor,
                    TextColor = QqinfoAppSettings.BlueColor
                };
                grid.Children.Add(new StackLayout() { BackgroundColor = QqinfoAppSettings.WhiteColor, Children = { hourLabel } }, 0, 1 + i);
            }
            #endregion

            #region time label
            var timeLabel = new Label()
            {
                Text = "Time",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = QqinfoAppSettings.SchedulerTextFontSize,
                BackgroundColor = QqinfoAppSettings.WhiteColor,
                TextColor = QqinfoAppSettings.BlueColor
            };
            grid.Children.Add(new StackLayout() { BackgroundColor = QqinfoAppSettings.WhiteColor, Children = { timeLabel } }, 0, 0);
            #endregion

            #region color each entry
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < assignmentList.Count + 1; j++)
                {
                    grid.Children.Add(new StackLayout() { BackgroundColor = QqinfoAppSettings.WhiteColor, HeightRequest = 75 }, j, i);
                }
            }
            #endregion

            #region populate the tasks
            foreach (var assignment in assignmentList)
            {
                foreach (var task in assignment.TasksInAssignment)
                {
                    var button = new Button()
                    {
                        Text = task.Name,
                        BackgroundColor = QqinfoAppSettings.GrayColor,
                        TextColor = QqinfoAppSettings.BlueColor,
                        BorderColor = QqinfoAppSettings.BlueColor,
                        BorderWidth = 0.5
                    };
                    button.Clicked += (s, e) =>
                    {
                        var currentTask = assignmentList.FirstOrDefault(a => a.Id == 2).TasksInAssignment.FirstOrDefault(t=>t.Id==12);
                        Navigation.PushAsync(new StepsForAssignmentTaskPage(currentTask));
                    };

                    grid.Children.Add(button, assignment.Id, task.StartHour - 7);
                    Grid.SetRowSpan(button, task.Duration);
                }
            }
            #endregion

            Content = new ScrollView() { Content = grid, Padding = new Thickness(3, 4, 3, 0), BackgroundColor = QqinfoAppSettings.GrayColor };
        }
    }
}
