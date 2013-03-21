using System.Collections.Generic;
using NUnit.Framework;
using SharpRepository.Tests.Integration.Data;

namespace SharpRepository.Tests.Integration.TestAttributes
{
    public class ExecuteForRepositoriesAttribute : TestCaseSourceAttribute
    {
        private static IEnumerable<TestCaseData> ForRepositoriesTestCaseData
        {
            get
            {
                return RepositoryTestCaseDataFactory.Build(_includeType);
            }
        }

        private static RepositoryType[] _includeType;
                
        public ExecuteForRepositoriesAttribute(params RepositoryType[] repositoryType) : this()
        {
            _includeType = repositoryType;
        }

        public ExecuteForRepositoriesAttribute() : base(typeof(ExecuteForRepositoriesAttribute), "ForRepositoriesTestCaseData")
        {
        }
    }
}