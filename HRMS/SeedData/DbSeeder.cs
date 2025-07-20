using Bogus;
using HRMS.Data;
using HRMS.Models;

namespace HRMS.SeedData
{
    public class DbSeeder
    {
        public static void SeedBranches(AppDbContext context)
        {
            if (context.Branches.Any()) return;

            var faker = new Faker<Branch>()
                .RuleFor(b => b.BranchName, f => f.Company.CompanyName())
                .RuleFor(b => b.BranchEmailAddress, f => f.Internet.Email())
                .RuleFor(b => b.BranchAddress, f => f.Address.FullAddress())
                .RuleFor(b => b.ContactNo, f => f.Phone.PhoneNumber())
                .RuleFor(b => b.LandlineNo, f => f.Phone.PhoneNumber("(04) ### ####"))
                .RuleFor(b => b.FaxNo, f => f.Phone.PhoneNumber())
                .RuleFor(b => b.City, f => f.Address.City())
                .RuleFor(b => b.BranchCityCode, f => f.Random.String2(5, "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"))
                .RuleFor(b => b.BranchPostalCode, f => f.Address.ZipCode())
                .RuleFor(b => b.BranchLabourFileno, f => f.Random.AlphaNumeric(10))
                .RuleFor(b => b.BranchAreaManager, f => f.Name.FullName())
                .RuleFor(b => b.BranchManager, f => f.Name.FullName())
                .RuleFor(b => b.BranchAssistantManager, f => f.Name.FullName())
                .RuleFor(b => b.CreatedBy, f => "Seeder")
                .RuleFor(b => b.BranchStatus, f => BranchStatusEnum.Active)
                .RuleFor(b => b.CreatedAt, f => DateTime.Now);

            var branches = faker.Generate(15);
            context.Branches.AddRange(branches);
            context.SaveChanges();
        }
    }
}
