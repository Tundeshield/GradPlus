using System;
using GradPlus.Data.Models.Domain;
using GradPlus.Data.IDAO;
using GradPlus.Data.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GradPlus.Data.Repository
{
    public class GradPlusInitialiser : 
        System.Data.Entity.DropCreateDatabaseIfModelChanges<GradPlusContext>
    {
        protected override void Seed(GradPlusContext context)
        {

            //to populate the job
            Job job1 = new Job()
            {
                JobTitle = "Software Developer Placement Role",
                CompanyName = "XYZ Company",
                CompanyAddress = "Manchester",
                ComapanyEmail = "xyz.xyz.com",
                CompanyWebsite = "www.xyz.com",
                Description = "Owner-managed business (t/o £5m pa) involved in the organisation of networking events and conferences. Office in Thorpe Park in Leeds - total of 40 staff. See www.built - environment - networking.com and www.ukreiif.com We run around 200 conferences each year.Our events are primarily based in the UK Property, Construction and Infrastructure industries. Job Role: " +
                "Work alongside the Marketing Director to manage the Marketing Team(team of circa 5) – including functions such as Email Marketing, Video Content, Website and Digital Marketing / CRO / UX." +
                "This isn’t just a management role – you’ll be very much required to do a lot of general marketing tasks in addition to helping manage the wider team – and work with the Marketing Director to deliver the tasks set out below. " +
                "To help drive the activation of the marketing strategy through various channels" +
                "Work closely with partners, sponsors and speakers to raise brand awareness, create content and deliver a sector leading experience" +
                "Take a data driven approach to marketing – suggesting areas for improvement and highlighting areas of weakness" +
                "Work with the email marketing and data team functions to improve and maximise the opportunities through automation, segmentation, personalisation etc." +
                "Both create and share content on our website, newsletter and social media channels" +
                "Help to improve the digital footprint – with a key focus on SEO, UX and CRO" +
                "Daily tasks to include: sharing news content, working with sponsors / speakers to promote our events, help manage the email marketing team and action work, ensure the website is correctly update by stakeholders, uploading new events, posting across social etc." +
                "The person must:" +
                "Have experience of managing teams and / or external partners" +
                "Be a ‘do -er’ – there is need to be actively involved in tasks rather than just delegating to the team" +
                " Be incredibly pro - active and come up with innovation, fresh and new ideas" +
                " Be commercially driven, we’re an expanding business with growth as a key focus" +
                "Come to the table with ideas and new ways of working" +
                "Have experience of working across all types of marketing: digital, email, print etc." +
                "Good management skills to get the best out of our team" +
                "Have experience of building out campaigns to promote new launches, events, products etc." +
                "Exceptionally organised and quick to complete tasks" +
                "Take responsibility and accountability for the Marketing Team – striving to improve and exceed whilst ensuring quality isn’t compromised." +
                "Experience of:" +
                "Email marketing; preferably with knowledge of reporting, automation, segmentation etc." +
                "Utilising data such as Google Analytic" +
                "Digital marketing knowledge including PPC, SEO, UX, CRO" +
                "Social media; preferably utilising tools such as Hootsuite" +
                "Reporting; from general ROI of marketing activity to A/ B testing etc" +
                "Website Editing; preferably on a site such as WordPress – creating new pages and making edits" +
                "Person spec" +
                "An all-rounder with the ability to multi - task.This is a busy business, and the occupant of this role will be subject to constant demands from senior Directors." +
                "A self-motivated individual able to manage their own time effectively to meet the demands of the job and to prioritise effectively." +
                " An individual who is not afraid to put forward ideas and alternatives and will be comfortable highlighting problems and proposing solutions." +
                "An intelligent analytical person who can determine the key points/ questions that the conference should be working on." +
                " Package:" +
                " Between £30k and £35k depending on experience" +
                " Bonus Scheme" +
                " 25 Days annual holiday plus bank holidays" +
                " Child Care Vouchers" +
                " Cycle to Work Scheme" +
                "Applicants should send a CV and cover letter explaining why they want the job and why they think they will be a good fit; you will not be considered for interview if you do not send the cover letter." +
                "Successful applicants will be contacted for interview at our Leeds office.",

                Salary = 20000
            };

            context.Jobs.Add(job1);

            context.SaveChanges();
        }

    }
}
