namespace AssetTool
{
    [JsonAsset("NiagaraStackFunctionInput")]
    public class UNiagaraStackFunctionInput : UNiagaraStackItemContent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}