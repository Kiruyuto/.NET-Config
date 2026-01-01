1. Messages should follow the conventional commit message format (Omitting optional scope)
2. Documentation (note, help links, description, etc.) changes or additions should have a type of "docs"
   - This includes adding or modifying comment lines (lines starting with `#`)
   - Format: "docs: Add note on `RULE_ID` rule" or "docs: Update note for `RULE_ID` rule"
   - Do NOT include the content or reasoning from the note in the commit message
3. Commits that **modify a `dotnet_diagnostic.*.severity` line** (changing the assigned value from one severity to another) MUST have type of "chore" and follow this format:  "chore: Adjust `RULE_ID` severity to `NEW_SEVERITY`"
     - Example: chore: Adjust `CA1708` severity to `none`
     - This rule applies ONLY when the actual severity value is changed (e.g., `warning` → `none`)
     - **Adding comments does NOT count as a severity change**
4. The first line should be under 80 characters long
5. Do not add a commit description