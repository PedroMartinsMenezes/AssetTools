namespace AssetTool
{
    [JsonAsset("NiagaraScriptVariable")]
    public class UNiagaraScriptVariable : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}