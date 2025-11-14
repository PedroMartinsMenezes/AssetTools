namespace AssetTool
{
    [JsonAsset("ContentBrowserAssetContextMenuContext")]
    public class UContentBrowserAssetContextMenuContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserAssetViewContextMenuContext")]
    public class UContentBrowserAssetViewContextMenuContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserMenuContext")]
    public class UContentBrowserMenuContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserFolderContext")]
    public class UContentBrowserFolderContext : UContentBrowserMenuContext
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserAddNewContextMenuContext")]
    public class UContentBrowserAddNewContextMenuContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ContentBrowserToolbarMenuContext")]
    public class UContentBrowserToolbarMenuContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}