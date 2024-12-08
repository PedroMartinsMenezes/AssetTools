namespace AssetTool
{
    [JsonAsset("TriggerVolume")]
    public class ATriggerVolume : AVolume
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}