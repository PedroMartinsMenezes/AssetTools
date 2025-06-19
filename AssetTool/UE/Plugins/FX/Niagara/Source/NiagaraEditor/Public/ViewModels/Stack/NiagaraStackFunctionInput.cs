namespace AssetTool
{
    [JsonAsset("NiagaraStackFunctionInput")]
    public class UNiagaraStackFunctionInput : UNiagaraStackItemContent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}