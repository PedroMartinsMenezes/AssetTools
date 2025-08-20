namespace AssetTool
{
    [JsonAsset("CEEffectorActor")]
    public class ACEEffectorActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}