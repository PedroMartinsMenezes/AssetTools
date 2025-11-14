namespace AssetTool
{
    [JsonAsset("BasicLineSetComponentBase")]
    public class UBasicLineSetComponentBase : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Basic2DLineSetComponent")]
    public class UBasic2DLineSetComponent : UBasicLineSetComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Basic3DLineSetComponent")]
    public class UBasic3DLineSetComponent : UBasicLineSetComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}