
//
//   
//    using (var taskContext = new TaskDbContext())
//{
//    #region Inserting ProgramDetails

//    var programDetails1 = new ProgramDetails()
//    {
//        Id = Guid.NewGuid().ToString(),
//        ProgramTitle = "Test",
//        ProgramDescription = "Testing",
//        KeySkills = new List<string>(),
//        ProgramBenefits = "Free training and food",
//        ApplicationCriteria = "Be determined",
//        AdditionalInfo = new AdditionalInformation()
//        {
//            Id = Guid.NewGuid().ToString(),
//            ProgramType = "full remote",
//            ProgramStart = DateTime.Now,
//            ApplicationOpen = DateTime.Now,
//            ApplicationClose = DateTime.Now,
//            Duration = "5 hrs",
//            ProgramLocation = "UK",
//            MinQualification = "University Degree",
//            MaxNumberOfApplication = "50",
//        }
//    };

//    taskContext.ProgramDetails?.Add(programDetails1);
//    await taskContext.SaveChangesAsync();

//}
//#endregion

