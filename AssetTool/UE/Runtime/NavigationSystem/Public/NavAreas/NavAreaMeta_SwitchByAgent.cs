namespace AssetTool
{
    [JsonAsset("NavAreaMeta_SwitchByAgent")]
    public class UNavAreaMeta_SwitchByAgent : UNavAreaMeta
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}