namespace AssetTool
{
    [JsonAsset("TestActorWithProperties")]
    public class ATestActorWithProperties : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}