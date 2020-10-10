### 便利そうなUnity C#の拡張メソッドまとめ

#### MonoEx

```
// シーン上のコンポーネントを（なければ作成して）取得
MonoEx.CreateGetComopnent <T> ();

// シーン上に１つだけあるコンポーネントを取得
// * 抽象クラスにも使える（Interfaceには使えない）
MonoEx.GetOnlyOneComponent <T> ();

// シーン上に2つ以上同じコンポーネントがあるか判別
bool isDouble = MonoEx.DoubleComponentInScene<T> ()
```

##### 問題点
 * どれもFindObjectsOfType \<T\>を使ってるので重そう
 * FindObjectsOfTypeは対象が非アクティブだと検索しない
  
  
#### GameObjectEx
```
// 先祖コンポーネントを取得
gameObject.GetComponentInParents <T> ();
```
