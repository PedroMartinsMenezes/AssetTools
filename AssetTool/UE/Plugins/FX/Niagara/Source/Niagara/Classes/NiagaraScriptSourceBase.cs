namespace AssetTool
{
    [JsonAsset("NiagaraScriptSourceBase")]
    public class UNiagaraScriptSourceBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}