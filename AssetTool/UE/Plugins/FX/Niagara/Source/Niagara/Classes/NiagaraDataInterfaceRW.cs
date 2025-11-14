namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceRWBase")]
    public class UNiagaraDataInterfaceRWBase : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceGrid3D")]
    public class UNiagaraDataInterfaceGrid3D : UNiagaraDataInterfaceRWBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("NiagaraDataInterfaceGrid2D")]
    public class UNiagaraDataInterfaceGrid2D : UNiagaraDataInterfaceRWBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}