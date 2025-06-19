namespace AssetTool
{
    [JsonAsset("NiagaraDataInterface")]
    public class UNiagaraDataInterface : UNiagaraDataInterfaceBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}