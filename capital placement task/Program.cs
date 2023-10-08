using capital_placement_task;
using capital_placement_task.DTOs;
using capital_placement_task.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using Type = capital_placement_task.Models.Type;

using (var taskContext = new TaskDbContext())
{
    #region add new ApplicationForm
    //var applicationForm1 = new ApplicationForm()
    //{
    //    Id = Guid.NewGuid().ToString(),
    //    UploadCoverImage = "image.jpg",
    //    PersonalInfo = new PersonalInformation
    //    {
    //        FirstName = "solsticks",
    //        LastName = "Code",
    //        Email = "test@mymail.com",
    //        PhoneNumber = "1234567890",
    //        Nationality = "All Nationality",
    //        CurrentAddress = "My address",
    //        DateOfBirth = new DateTime(1902, 12, 01),
    //        Gender = "Male",
    //        AddAQuestion = new Questions()
    //    },
    //    Profiles = new Profile
    //    {
    //        Id = Guid.NewGuid().ToString(),
    //        Education = new Education()
    //        {
    //            School = "Global education",
    //            Degree = "Bachelors",
    //            CourseName = "Computers",
    //            LocationOfStudy = "UK",
    //            StartDate = new DateTime(1980, 12, 03),
    //            EndDate = new DateTime(1984, 12, 05)
    //        }            
    //    },
    //    AdditionalQuestions = new AdditionalQuestions()
    //    {
    //        AboutMe = "I am always excited about the opportunity to learn new things",
    //        GraduationYear = new DateOnly(1984, 12, 05),
    //        Question = new Questions
    //        {
    //            Question = "Do you want the job",
    //            Type = Type.YesOrNo
    //        }

    //    },
    //};
    //taskContext.ApplicationForms?.Add(applicationForm1);
    //await taskContext.SaveChangesAsync();
    #endregion

    #region get program details

    //if (taskContext.ProgramDetails != null)
    //{
    //    var programDetails = await taskContext.ProgramDetails.ToListAsync();

    //    foreach (var program in programDetails)
    //    {
    //        var prog = new GetProgramDetailDto
    //        {
    //            ProgramTitle = program.ProgramTitle,
    //            ProgramDescription = program.ProgramDescription,
    //            KeySkills = program.KeySkills,
    //            ProgramBenefits = program.ProgramBenefits,
    //            ApplicationCriteria = program.ApplicationCriteria,
    //            AdditionalInfo = program.AdditionalInfo,
    //        };
    //        Console.WriteLine("Program Description : " + prog.ProgramDescription?.ToString());
    //        Console.WriteLine("Program Title :" + prog.ProgramTitle?.ToString());
    //        Console.WriteLine("Program Application Criteria : " + prog.ApplicationCriteria?.ToString());
    //    }
    //}



    #endregion

    #region update application form
    if (taskContext.ProgramDetails != null)
    {
        var programDetails = await taskContext.ApplicationForms
                                .Where(e => e.PersonalInfo.Email == "test@mymail.com")
                                .FirstOrDefaultAsync();
        if (programDetails != null)
        {
            programDetails.Profiles.Experience = new WorkExperience
            {
                Company = "My Company",
                Title = "software Engineer",
                LocationOfWork = "UK",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now                
            };
            await taskContext.SaveChangesAsync();
            Console.WriteLine("Record Updated successfully");
        }
    }
    
        #endregion
}