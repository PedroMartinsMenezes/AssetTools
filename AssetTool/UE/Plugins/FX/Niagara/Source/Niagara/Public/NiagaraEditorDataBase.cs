namespace AssetTool
{
    [JsonAsset("NiagaraEditorDataBase")]
    public class UNiagaraEditorDataBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraEditorParametersAdapterBase")]
    public class UNiagaraEditorParametersAdapterBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}