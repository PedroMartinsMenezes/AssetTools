namespace AssetTool
{
    [JsonAsset("SwitchActor")]
    public class ASwitchActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}