namespace AssetTool
{
    [JsonAsset("Text3DActor")]
    public class AText3DActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}