namespace AssetTool
{
    [JsonAsset("NiagaraParameterDefinitionsBase")]
    public class UNiagaraParameterDefinitionsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}