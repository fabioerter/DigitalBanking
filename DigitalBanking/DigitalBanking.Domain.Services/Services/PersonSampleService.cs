using FluentValidation;
using DigitalBanking.Domain.Core.Interfaces.Repositories;
using DigitalBanking.Domain.Core.Interfaces.Services;
using DigitalBanking.Domain.Entities;
using DigitalBanking.Domain.Services.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBanking.Domain.Services.Services
{
    public class PersonSampleService : Service<PersonSample>, IPersonSampleService
    {
        public PersonSampleService(IUnitOfWork context, IPersonSampleRepository personSampleRepository) : base(context, personSampleRepository)
        {
            Validator = new PersonSampleValidator();
        }

        public override PersonSample Insert(PersonSample obj)
        {
            if (Context.ValidateEntity)
                Validator.Validate(obj, options =>
                {
                    options.ThrowOnFailures();
                    options.IncludeRuleSets("Insert");
                });

            if ((DateTime.Now.Year - obj.DateBirth.Year) < 18)
                throw new ValidationException("Registration is not allowed to the under 18 years");

            return Repository.Insert(obj);
        }
    }
}
