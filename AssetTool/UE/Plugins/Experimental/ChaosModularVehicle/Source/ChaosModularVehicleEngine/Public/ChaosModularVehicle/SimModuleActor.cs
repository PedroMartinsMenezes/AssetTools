namespace AssetTool
{
    [JsonAsset("SimModuleActor")]
    public class ASimModuleActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}