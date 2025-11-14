namespace AssetTool
{
    [JsonAsset("DefaultEditorProfiles")]
    public class UDefaultEditorProfiles : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LocalProfiles")]
    public class ULocalProfiles : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SharedProfiles")]
    public class USharedProfiles : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetViewerSettings")]
    public class UAssetViewerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}