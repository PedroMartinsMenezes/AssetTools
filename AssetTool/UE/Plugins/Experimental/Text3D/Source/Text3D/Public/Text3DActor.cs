namespace AssetTool
{
    [JsonAsset("Text3DActor")]
    public class AText3DActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}