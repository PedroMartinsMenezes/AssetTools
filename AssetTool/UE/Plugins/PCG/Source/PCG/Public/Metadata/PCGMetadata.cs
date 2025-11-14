namespace AssetTool
{
    [JsonAsset("PCGMetadata")]
    public class UPCGMetadata : UObject
    {
        public FPCGMetadataDomain DefaultMetadataDomain;
        public FPCGMetadataDomainID ArchiveDefaultDomain;
        public List<FPCGMetadataDomainID> DomainIDs;
        public ValidMetadataDomain[] ValidDomains;

        [Location("void UPCGMetadata::Serialize(FArchive& InArchive)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.Supports.MultiLevelMetadata)
            {
                transfer.Move(ref DefaultMetadataDomain);
            }
            else
            {
                transfer.Move(ref ArchiveDefaultDomain);
                transfer.Move(ref DomainIDs);
                transfer.Resize(ref ValidDomains, DomainIDs.Count);
                for (int i = 0; i < DomainIDs.Count; i++)
                {
                    transfer.Move(ref ValidDomains[i], DomainIDs[i].IsDefault());
                }
            }
            return this;
        }

        public class ValidMetadataDomain : ITransferable<bool>
        {
            public FBool bIsValid;
            public FPCGMetadataDomain NewMetadataDomain;

            public ITransferable Move(Transfer transfer, bool isDefault)
            {
                transfer.Move(ref bIsValid);
                if (!isDefault && bIsValid)
                {
                    transfer.Move(ref NewMetadataDomain);
                }
                return this;
            }

            public ITransferable Move(Transfer transfer)
            {
                throw new NotImplementedException();
            }
        }
    }
}