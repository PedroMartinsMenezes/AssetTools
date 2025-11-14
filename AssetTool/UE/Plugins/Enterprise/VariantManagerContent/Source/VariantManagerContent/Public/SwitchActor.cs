namespace AssetTool
{
    [JsonAsset("SwitchActor")]
    public class ASwitchActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}