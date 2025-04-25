# KnightRPG 專案 - 關卡設計分支使用說明

此README為關卡設計人員專用，請**僅針對關卡進行內容設計，不要修改程式碼與其他資料夾**。

---

## ✅ 你可以做的事

✔ 進行以下項目：
- 編輯或新增場景 `.unity` 檔，建議命名為：
Assets/Scenes/Level_地點.unity
- 使用已經建立的 prefab 來設計場景（怪物、道具、NPC...）
- 調整地形、碰撞、裝飾等場景元素
- 修改 `Assets/Scenes/Level_Design/` 內的場景

---

## 🚫 請勿修改以下內容

❌ 禁止更動以下資料夾與檔案：
- `Assets/Scripts/` 內的任何程式碼（功能由主程式負責）
- `Assets/Prefabs/` 內 prefab 的內容（可拖曳使用但不要編輯原始物件）
- `ProjectSettings/`（會影響整體 Unity 設定）
- `Assets/Scenes/Main.unity`（主場景）
- `.cs`、`.meta` 以外的系統檔案

---

## 🔄 提交與合併流程

1. 完成關卡後，在 GitHub Desktop 提交（commit）並推送（push）到 `level-editor-Aaron` 分支。
2. 通知專案管理者（鄭曦燕）開啟 Pull Request 合併至 `main` 分支。
3. 每次開始前記得 `Pull` 最新的 `main` 分支內容以避免衝突。

---

## 🛠 小提示

- 請盡量將關卡中物件使用「Prefab 拖曳」的方式，不要直接建立原始 GameObject。
- 若需新增 Prefab，請與負責程式的開發人員溝通後進行。
- 場景請保持命名清晰，例如：
Level_Forest.unity Level_Cave.unity

---

## 🙌 謝謝你幫忙設計場景！

有任何 Unity 操作問題請隨時聯繫我
