namespace AssetTool
{
    [JsonAsset("NiagaraScriptVariable")]
    public class UNiagaraScriptVariable : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}