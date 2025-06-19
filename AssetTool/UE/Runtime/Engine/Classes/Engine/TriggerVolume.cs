namespace AssetTool
{
    [JsonAsset("TriggerVolume")]
    public class ATriggerVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}