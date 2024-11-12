namespace AssetTool
{
    [JsonAsset("NiagaraParameterDefinitions")]
    public class UNiagaraParameterDefinitions : UNiagaraParameterDefinitionsBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}