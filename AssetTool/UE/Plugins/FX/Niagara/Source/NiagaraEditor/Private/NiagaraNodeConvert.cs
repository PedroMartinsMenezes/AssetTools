namespace AssetTool
{
    [JsonAsset("NiagaraNodeConvert")]
    public class UNiagaraNodeConvert : UNiagaraNodeWithDynamicPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}