// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Reading.Linq;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertProductOperation1360380871
    public class UpsertProductOperation1360380871 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly DocumentDbTests.Reading.Linq.Product _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertProductOperation1360380871(DocumentDbTests.Reading.Linq.Product document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_product(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertProductOperation1360380871
    
    
    // START: InsertProductOperation1360380871
    public class InsertProductOperation1360380871 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly DocumentDbTests.Reading.Linq.Product _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertProductOperation1360380871(DocumentDbTests.Reading.Linq.Product document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_product(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertProductOperation1360380871
    
    
    // START: UpdateProductOperation1360380871
    public class UpdateProductOperation1360380871 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly DocumentDbTests.Reading.Linq.Product _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateProductOperation1360380871(DocumentDbTests.Reading.Linq.Product document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_product(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateProductOperation1360380871
    
    
    // START: QueryOnlyProductSelector1360380871
    public class QueryOnlyProductSelector1360380871 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.Product>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyProductSelector1360380871(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.Product Resolve(System.Data.Common.DbDataReader reader)
        {

            DocumentDbTests.Reading.Linq.Product document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.Product>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.Product> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DocumentDbTests.Reading.Linq.Product document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.Product>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyProductSelector1360380871
    
    
    // START: LightweightProductSelector1360380871
    public class LightweightProductSelector1360380871 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DocumentDbTests.Reading.Linq.Product, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.Product>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightProductSelector1360380871(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.Product Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DocumentDbTests.Reading.Linq.Product document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.Product>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.Product> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DocumentDbTests.Reading.Linq.Product document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.Product>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightProductSelector1360380871
    
    
    // START: IdentityMapProductSelector1360380871
    public class IdentityMapProductSelector1360380871 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DocumentDbTests.Reading.Linq.Product, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.Product>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapProductSelector1360380871(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.Product Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.Product document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.Product>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.Product> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.Product document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.Product>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapProductSelector1360380871
    
    
    // START: DirtyTrackingProductSelector1360380871
    public class DirtyTrackingProductSelector1360380871 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DocumentDbTests.Reading.Linq.Product, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Reading.Linq.Product>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingProductSelector1360380871(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Reading.Linq.Product Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.Product document;
            document = _serializer.FromJson<DocumentDbTests.Reading.Linq.Product>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Reading.Linq.Product> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Reading.Linq.Product document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Reading.Linq.Product>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingProductSelector1360380871
    
    
    // START: QueryOnlyProductDocumentStorage1360380871
    public class QueryOnlyProductDocumentStorage1360380871 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyProductDocumentStorage1360380871(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.Product document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.Product document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyProductSelector1360380871(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyProductDocumentStorage1360380871
    
    
    // START: LightweightProductDocumentStorage1360380871
    public class LightweightProductDocumentStorage1360380871 : Marten.Internal.Storage.LightweightDocumentStorage<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightProductDocumentStorage1360380871(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.Product document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.Product document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightProductSelector1360380871(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightProductDocumentStorage1360380871
    
    
    // START: IdentityMapProductDocumentStorage1360380871
    public class IdentityMapProductDocumentStorage1360380871 : Marten.Internal.Storage.IdentityMapDocumentStorage<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapProductDocumentStorage1360380871(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.Product document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.Product document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapProductSelector1360380871(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapProductDocumentStorage1360380871
    
    
    // START: DirtyTrackingProductDocumentStorage1360380871
    public class DirtyTrackingProductDocumentStorage1360380871 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingProductDocumentStorage1360380871(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Reading.Linq.Product document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertProductOperation1360380871
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Reading.Linq.Product, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Reading.Linq.Product document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Reading.Linq.Product document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingProductSelector1360380871(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingProductDocumentStorage1360380871
    
    
    // START: ProductBulkLoader1360380871
    public class ProductBulkLoader1360380871 : Marten.Internal.CodeGeneration.BulkLoader<DocumentDbTests.Reading.Linq.Product, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Reading.Linq.Product, System.Guid> _storage;

        public ProductBulkLoader1360380871(Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Reading.Linq.Product, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_product(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_product_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_product (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_product_temp.\"id\", mt_doc_product_temp.\"data\", mt_doc_product_temp.\"mt_version\", mt_doc_product_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_product_temp left join public.mt_doc_product on mt_doc_product_temp.id = public.mt_doc_product.id where public.mt_doc_product.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_product target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_product_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_product_temp as select * from public.mt_doc_product limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Reading.Linq.Product document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Reading.Linq.Product document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: ProductBulkLoader1360380871
    
    
    // START: ProductProvider1360380871
    public class ProductProvider1360380871 : Marten.Internal.Storage.DocumentProvider<DocumentDbTests.Reading.Linq.Product>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public ProductProvider1360380871(Marten.Schema.DocumentMapping mapping) : base(new ProductBulkLoader1360380871(new QueryOnlyProductDocumentStorage1360380871(mapping)), new QueryOnlyProductDocumentStorage1360380871(mapping), new LightweightProductDocumentStorage1360380871(mapping), new IdentityMapProductDocumentStorage1360380871(mapping), new DirtyTrackingProductDocumentStorage1360380871(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: ProductProvider1360380871
    
    
}

