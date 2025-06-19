namespace AssetTool
{
    [JsonAsset("NiagaraParameterDefinitions")]
    public class UNiagaraParameterDefinitions : UNiagaraParameterDefinitionsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}