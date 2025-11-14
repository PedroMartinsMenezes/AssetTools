namespace AssetTool
{
    [JsonAsset("RuntimeVirtualTextureComponent")]
    public class URuntimeVirtualTextureComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}