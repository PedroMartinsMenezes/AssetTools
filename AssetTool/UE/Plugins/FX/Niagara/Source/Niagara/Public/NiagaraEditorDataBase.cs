namespace AssetTool
{
    [JsonAsset("NiagaraEditorDataBase")]
    public class UNiagaraEditorDataBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraEditorParametersAdapterBase")]
    public class UNiagaraEditorParametersAdapterBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}