namespace AssetTool
{
    [JsonAsset("SimModuleActor")]
    public class ASimModuleActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}