namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceRWBase")]
    public class UNiagaraDataInterfaceRWBase : UNiagaraDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceGrid3D")]
    public class UNiagaraDataInterfaceGrid3D : UNiagaraDataInterfaceRWBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceGrid2D")]
    public class UNiagaraDataInterfaceGrid2D : UNiagaraDataInterfaceRWBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}