namespace AssetTool
{
    [JsonAsset("GeometryMaskCanvasReferenceComponentBase")]
    public class UGeometryMaskCanvasReferenceComponentBase : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}