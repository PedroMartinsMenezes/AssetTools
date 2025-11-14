namespace AssetTool
{
    [JsonAsset("BasicPointSetComponentBase")]
    public class UBasicPointSetComponentBase : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Basic2DPointSetComponent")]
    public class UBasic2DPointSetComponent : UBasicPointSetComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Basic3DPointSetComponent")]
    public class UBasic3DPointSetComponent : UBasicPointSetComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}