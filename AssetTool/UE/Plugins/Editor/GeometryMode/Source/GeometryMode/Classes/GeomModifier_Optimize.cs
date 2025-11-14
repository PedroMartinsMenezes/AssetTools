namespace AssetTool
{
    [JsonAsset("GeomModifier_Optimize")]
    public class UGeomModifier_Optimize : UGeomModifier_Triangulate
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}