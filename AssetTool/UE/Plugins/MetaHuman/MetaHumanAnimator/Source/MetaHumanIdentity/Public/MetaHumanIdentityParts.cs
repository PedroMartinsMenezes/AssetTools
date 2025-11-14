namespace AssetTool
{
    [JsonAsset("MetaHumanIdentityPart")]
    public class UMetaHumanIdentityPart : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityFace")]
    public class UMetaHumanIdentityFace : UMetaHumanIdentityPart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityBody")]
    public class UMetaHumanIdentityBody : UMetaHumanIdentityPart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityHands")]
    public class UMetaHumanIdentityHands : UMetaHumanIdentityPart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityOutfit")]
    public class UMetaHumanIdentityOutfit : UMetaHumanIdentityPart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanIdentityProp")]
    public class UMetaHumanIdentityProp : UMetaHumanIdentityPart
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanTemplateMesh")]
    public class UMetaHumanTemplateMesh : UDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}