namespace AssetTool
{
    [JsonAsset("NiagaraNodeStaticSwitch")]
    public class UNiagaraNodeStaticSwitch : UNiagaraNodeUsageSelector
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}