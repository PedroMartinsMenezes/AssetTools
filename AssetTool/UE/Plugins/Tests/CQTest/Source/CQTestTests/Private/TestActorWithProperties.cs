namespace AssetTool
{
    [JsonAsset("TestActorWithProperties")]
    public class ATestActorWithProperties : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}