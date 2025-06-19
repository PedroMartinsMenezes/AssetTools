namespace AssetTool
{
    [JsonAsset("RuntimeVirtualTextureComponent")]
    public class URuntimeVirtualTextureComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}