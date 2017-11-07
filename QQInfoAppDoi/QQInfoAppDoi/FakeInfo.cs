using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using QQInfoAppDoi.Model;
using QQInfoAppDoi.View;

namespace QQInfoAppDoi
{
    public class FakeInfo
    {
        public static List<User> ReturnUsersList()
        {
            return new List<User>()
            {
                new User() {Name = "Kate", IsWorkingToday = true},
                new User() {Name = "Bob", IsWorkingToday = true},
                new User() {Name = "John", IsWorkingToday = true},
                new User() {Name = "Donald", IsWorkingToday = false}
            };
        }

        #region maybe for later
        //public static List<Assignment> ReturnUsersAssignmentsList()
        //{
        //    return new List<Assignment>()
        //    {
        //        new Assignment()
        //        {
        //            Name = "Assignment 1",
        //            Id = 1,
        //            TasksInAssignment = new List<AssignmentTask>()
        //            {
        //                new AssignmentTask() { Name = "Task 1 in Assignment 1", StartHour = 8, Duration = 4, Description = "Description for task 1 in assignment 1"},
        //                new AssignmentTask() { Name = "Task 2 in Assignment 1", StartHour = 14, Duration = 2, Description = "Description for task 2 in assignment 1"}
        //            }
        //        },
        //        new Assignment()
        //        {
        //            Id = 2,
        //            Name = "Assignment 2",
        //            TasksInAssignment = new List<AssignmentTask>()
        //            {
        //                new AssignmentTask() { Name = "Task 1 in Assignment 2", StartHour = 9, Duration = 6, Description = "Description for task 1 in assignment 2"}
        //            }
        //        },
        //        new Assignment()
        //        {
        //            Id=3,
        //            Name = "Assignment 3",
        //            TasksInAssignment = new List<AssignmentTask>()
        //            {
        //                new AssignmentTask() { Name = "Task 1 in Assignment 3", StartHour = 9, Duration = 2, Description = "Description for task 1 in assignment 3"},
        //                new AssignmentTask() { Name = "Task 2 in Assignment 3", StartHour = 12, Duration = 4, Description = "Description for task 2 in assignment 3"},
        //            }
        //        },
        //        //new Assignment()
        //        //{
        //        //    Id = 4,
        //        //    Name = "Assignment 4",
        //        //    TasksInAssignment = new List<AssignmentTask>()
        //        //    {
        //        //        new AssignmentTask() { Name = "Task 1 in Assignment 4", StartHour = 9, Duration = 6, Description = "Description for task 1 in assignment 4"}
        //        //    }
        //        //},
        //    };
        //}
#endregion

        public static List<Assignment> ReturnUsersAssignmentsList()
        {
            return new List<Assignment>()
            {
                new Assignment()
                {
                    Name = "Bread",
                    Id = 1,
                    TasksInAssignment = new List<AssignmentTask>()
                    {
                        new AssignmentTask() {Id = 10, Name = "100 baguette", StartHour = 8, Duration = 4, NumberOfPieces = 100},
                        new AssignmentTask() {Id = 11, Name = "10 focaccia", StartHour = 14, Duration = 2, NumberOfPieces = 10}
                    }
                },
                new Assignment()
                {
                    Id = 2,
                    Name = "Cornuri",
                    TasksInAssignment = new List<AssignmentTask>()
                    {
                        new AssignmentTask() {Id = 12, Name = "40 bagel", StartHour = 9, Duration = 6, NumberOfPieces = 40}
                    }
                },
                new Assignment()
                {
                    Id=3,
                    Name = "Saleuri",
                    TasksInAssignment = new List<AssignmentTask>()
                    {
                        new AssignmentTask() {Id = 13, Name = "700g biscuit", StartHour = 9, Duration = 2},
                        new AssignmentTask() {Id = 14, Name = "300g crouton", StartHour = 12, Duration = 4},
                    }
                }
            };
        }

        public static List<Step> ReturnStepsForAssignmentTask(int taskId)
        {
            var allSteps = new List<Step>
            {
                new Step() {Id = 1, AssignementTaskId = 12, Name = "Dough preparation", HasDetails = true, RealizationTimeInMinutes = 60, IsNotDone = true, TextColor = QqinfoAppSettings.BlueColor},
                new Step() {Id = 2, AssignementTaskId = 12, Name = "Fermentation", HasDetails = false, RealizationTimeInMinutes = 120, IsNotDone = true, TextColor = QqinfoAppSettings.BlueColor},
                new Step() {Id = 3, AssignementTaskId = 12, Name = "Portioning", HasDetails = false, RealizationTimeInMinutes = 60, IsNotDone = true, TextColor = QqinfoAppSettings.BlueColor},
                new Step() {Id = 4, AssignementTaskId = 12, Name = "Add chocolate", HasDetails = true, RealizationTimeInMinutes = 30, IsNotDone = true, TextColor = QqinfoAppSettings.BlueColor},
                new Step() {Id = 5, AssignementTaskId = 12, Name = "Baking", HasDetails = true, RealizationTimeInMinutes = 90, IsNotDone = true, TextColor = QqinfoAppSettings.BlueColor}
            };

            return allSteps.Where(s => s.AssignementTaskId == taskId).ToList();
        }

        public static List<Ingredient> ReturnIngredientsForStep(int stepId)
        {
            var ingredients = new List<Ingredient>
            {
                new Ingredient {Id = 1, Name = "Flour", Grammage = "2 kg", HasDetails = true},
                new Ingredient {Id = 2, Name = "Water", Grammage = "2 L", HasDetails = false},
                new Ingredient {Id = 3, Name = "Yeast", Grammage = "300 g", HasDetails = false}
            };

            return ingredients;
        }

        public static List<IngredientBatch> ReturnIngredientBatchForIngredient(int ingredientId)
        {
            var ingredientBatch = new List<IngredientBatch>
            {
                new IngredientBatch {Id = 1, Name = "Bread Flour 10kg", Batch = "00123", ExpirationDate = "31.08.2017"},
                new IngredientBatch {Id = 2, Name = "Bread Flour 10kg", Batch = "00246", ExpirationDate = "31.12.2017"},
                new IngredientBatch {Id = 3, Name = "Cake Flour 8kg", Batch = "12937", ExpirationDate = "31.01.2018"},
                new IngredientBatch {Id = 4, Name = "Cake Flour 8kg", Batch = "12385", ExpirationDate = "31.05.2018"},
                new IngredientBatch {Id = 5, Name = "Pastry Flour 12kg", Batch = "13423", ExpirationDate = "31.10.2018"}
            };

            return ingredientBatch;
        }
    }
}
