namespace AssetTool
{
    [JsonAsset("NiagaraParameterDefinitionsBase")]
    public class UNiagaraParameterDefinitionsBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}