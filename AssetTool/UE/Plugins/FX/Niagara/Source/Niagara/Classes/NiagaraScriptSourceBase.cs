namespace AssetTool
{
    [JsonAsset("NiagaraScriptSourceBase")]
    public class UNiagaraScriptSourceBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}