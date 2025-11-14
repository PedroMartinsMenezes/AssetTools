namespace AssetTool
{
    [JsonAsset("SphereReflectionCapture")]
    public class ASphereReflectionCapture : AReflectionCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}