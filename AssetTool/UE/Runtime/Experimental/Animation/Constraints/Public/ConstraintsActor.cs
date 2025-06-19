namespace AssetTool
{
    [JsonAsset("AConstraintsActor")]
    public class AConstraintsActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}