namespace AssetTool
{
    [JsonAsset("SimModuleActor")]
    public class ASimModuleActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}