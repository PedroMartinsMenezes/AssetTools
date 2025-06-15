namespace AssetTool
{
    [JsonAsset("NavAreaMeta_SwitchByAgent")]
    public class UNavAreaMeta_SwitchByAgent : UNavAreaMeta
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}