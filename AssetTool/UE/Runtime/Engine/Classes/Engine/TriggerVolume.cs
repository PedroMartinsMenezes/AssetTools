namespace AssetTool
{
    [JsonAsset("TriggerVolume")]
    public class ATriggerVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}