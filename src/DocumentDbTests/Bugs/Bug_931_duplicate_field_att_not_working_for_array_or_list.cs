using System;
using System.Collections.Generic;
using Marten.Schema;
using Marten.Storage;
using Marten.Testing.Harness;
using Shouldly;
using Xunit;

namespace DocumentDbTests.Bugs
{
    public class Bug_931_duplicate_field_att_not_working_for_array_or_list: IntegrationContext
    {
        [Fact]
        public void can_create_for_array()
        {
            var mapping = DocumentMapping.For<DupFieldAttTest>();
            var table = new DocumentTable(mapping);
            table.HasColumn("array_tags").ShouldBeTrue();
        }

        [Fact]
        public void can_create_for_list()
        {
            var mapping = DocumentMapping.For<DupFieldAttTest>();
            var table = new DocumentTable(mapping);
            table.HasColumn("list_tags").ShouldBeTrue();
        }

        public Bug_931_duplicate_field_att_not_working_for_array_or_list(DefaultStoreFixture fixture) : base(fixture)
        {
        }
    }

    public class DupFieldAttTest
    {
        public Guid Id { get; set; }

        [DuplicateField(PgType = "varchar[]")]
        public string[] ArrayTags { get; set; }

        [DuplicateField(PgType = "varchar[]")]
        public List<string> ListTags { get; set; }
    }
}
