#!/usr/bin/env bash

set -euo pipefail

if [[ $# -lt 10 ]]; then
  echo "Usage: progress-step.sh <repository> <issue_number> <comment_body> <trigger_phrase> <current_workflow> <next_workflow> <next_step_file> <transition_message> <reminder_message> <mode> [closing_message]" >&2
  exit 1
fi

repository="$1"
issue_number="$2"
comment_body="$3"
trigger_phrase="$4"
current_workflow="$5"
next_workflow="$6"
next_step_file="$7"
transition_message="$8"
reminder_message="$9"
mode="${10}"
closing_message="${11:-}"

normalized_comment="$(printf '%s' "$comment_body" | tr '[:upper:]' '[:lower:]')"
normalized_trigger="$(printf '%s' "$trigger_phrase" | tr '[:upper:]' '[:lower:]')"

if [[ "$normalized_comment" != *"$normalized_trigger"* ]]; then
  gh issue comment "$issue_number" --repo "$repository" --body "$reminder_message"
  exit 0
fi

gh issue comment "$issue_number" --repo "$repository" --body "$transition_message"

if [[ "$mode" == "final" ]]; then
  gh issue comment "$issue_number" --repo "$repository" --body "$closing_message"
  gh issue close "$issue_number" --repo "$repository"
  gh workflow disable "$current_workflow" --repo "$repository" || true
  exit 0
fi

gh issue comment "$issue_number" --repo "$repository" --body-file "$next_step_file"
gh workflow disable "$current_workflow" --repo "$repository" || true
gh workflow enable "$next_workflow" --repo "$repository"
