namespace AssetTool
{
    [JsonAsset("CEClonerActor")]
    public class ACEClonerActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
