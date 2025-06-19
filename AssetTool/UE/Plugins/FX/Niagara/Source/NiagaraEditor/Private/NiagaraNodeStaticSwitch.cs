namespace AssetTool
{
    [JsonAsset("NiagaraNodeStaticSwitch")]
    public class UNiagaraNodeStaticSwitch : UNiagaraNodeUsageSelector
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}