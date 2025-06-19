namespace AssetTool
{
    //[JsonAsset("NiagaraStackValueCollection")]
    //public class UNiagaraStackValueCollection : UNiagaraStackItemContent
    //{
    //    public override ITransferible Move(Transfer transfer)
    //    {
    //        return base.Move(transfer);
    //    }
    //}

    [JsonAsset("NiagaraStackFunctionInputCollection")]
    public class UNiagaraStackFunctionInputCollection : UNiagaraStackValueCollection
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}