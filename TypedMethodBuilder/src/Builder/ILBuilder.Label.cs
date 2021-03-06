namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, TCallStack> MarkLabel<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Void> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpMarkLabel(label));

        public static IL<TParameter, TLocal, TCallStack> MarkLabel<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpMarkLabel(label));

        public static IL<TParameter, TLocal, TCallStack> MarkLabel<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpMarkLabel(newLabel));
    }
}
